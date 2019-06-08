using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace EgitimUygulamasi.Database
{
    class InitialCreate
    {

        private string kategori = "CREATE TABLE if not exists kategoriler(id int primary key auto_increment, ad varchar(45),aciklama text)   ENGINE = INNODB;";
        private string sorular = "CREATE TABLE if not exists sorular(id int primary key auto_increment, kategori_id int,medya_id int,sure int,soruBasligi text,zorlukSeviyesi varchar(45),FOREIGN KEY (kategori_id) REFERENCES kategoriler(id) ON DELETE CASCADE,FOREIGN KEY (medya_id) REFERENCES medya(id)) ENGINE = INNODB;";
        private string secenekler = "CREATE TABLE if not exists secenekler(soru_id int not null,asecenegi text,bsecenegi text,csecenegi text,dsecenegi text, esecenegi text,dogru text,CONSTRAINT fk_soru FOREIGN KEY(soru_id) REFERENCES sorular(id) ON DELETE CASCADE) engine = innodb; ";
        private string veritabani = "CREATE DATABASE IF NOT EXISTS egitim DEFAULT CHARACTER SET utf8 DEFAULT COLLATE utf8_turkish_ci";
        private string admin = "CREATE TABLE if not exists admin (id int primary key auto_increment, ad varchar(50),soyad varchar(50),kadi varchar(50) unique not null,sifre text)   ENGINE = INNODB;";
        private string calisan = "CREATE TABLE if not exists calisan(id int primary key auto_increment,ad varchar(50),soyad varchar(50),mail varchar(100),kadi varchar(50),sifre text)   ENGINE = INNODB;";
        private string puanlar = "CREATE TABLE if not exists puanlar(calisan_id int unique,puan int, CONSTRAINT fk_calisan FOREIGN KEY(calisan_id) REFERENCES calisan(id) ON DELETE CASCADE) ENGINE = INNODB;";
        private string medya = "CREATE TABLE if not exists medya (id int primary key auto_increment, kategori_id int,medya_path text,medya_ismi varchar(70),CONSTRAINT FK_Kategori FOREIGN KEY(kategori_id) REFERENCES kategoriler(id)) ENGINE = INNODB;";
        private string puanturleri = "CREATE TABLE if not exists puanturleri (id int primary key auto_increment, kategori_tur varchar(50),puan int) engine = innodb;";
        private string ayarlar = "Create table if not exists ayarlar(id int primary key auto_increment, ad varchar(50), deger int) engine=innodb; ";
        private string sorulmatarihleri = "create table if not exists sorulmatarihleri(id int primary key auto_increment,soru_id int,calisan_id int, tarih date,foreign key (soru_id) references sorular(id),foreign key (calisan_id) references calisan(id)) engine = innodb;";
        private string calisancevaplari = "create table if not exists calisancevaplari(id int primary key auto_increment,soru_id int,calisan_id int ,tarih date,sure int,cevap varchar(10),foreign key(soru_id) references sorular(id),foreign key (calisan_id) references calisan(id)) engine = innodb; ";

        MySqlConnection _connection = new MySqlConnection("server=localhost;uid=root;");
        MySqlConnection _connection1 = null;
        public void veritabaniOlustur()
        {
            try
            {
                _connection.Open();
                MySqlCommand cmdVeritabani = new MySqlCommand(veritabani, _connection);
                cmdVeritabani.ExecuteNonQuery();
                _connection.Close();
                _connection1 = new MySqlConnection("server=localhost;userid=root;Database=egitim;");

            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }

        public void tablolariOlustur()
        {
            try
            {
                _connection1.Open();
                MySqlCommand cmdTablolar = new MySqlCommand(kategori, _connection1);


                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = medya;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = sorular;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = secenekler;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = admin;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = calisan;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = puanlar;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = puanturleri;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = ayarlar;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = sorulmatarihleri;
                cmdTablolar.ExecuteNonQuery();
                cmdTablolar.CommandText = calisancevaplari;
                cmdTablolar.ExecuteNonQuery();
                _connection1.Close();

            }
            catch (Exception ex)
            {
                Debug.Write(ex.HelpLink);
            }

        }

        public void adminOlustur()
        {
            try
            {
                _connection1.Close();
                string ilkadmin = "insert into admin values(0,'niyazi','ekinci','nekinci','0000')";
                _connection1.Open();
                MySqlCommand cmdAdmin = new MySqlCommand(ilkadmin, _connection1);
                cmdAdmin.ExecuteNonQuery();
                _connection1.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void PuanlariAta()
        {
            _connection1 = new MySqlConnection("server=localhost;userid=root;Database=egitim;");
            var kolay = "insert into puanturleri values(0,'Kolay',3)";
            var orta = "insert into puanturleri values(0,'Orta',5)";
            var zor = "insert into puanturleri values(0,'Zor',8)";

            _connection1.Open();

            MySqlCommand cmd = new MySqlCommand(kolay, _connection1);
            cmd.ExecuteNonQuery();
            cmd.CommandText = orta;
            cmd.ExecuteNonQuery();
            cmd.CommandText = zor;
            cmd.ExecuteNonQuery();

            _connection.Close();

        }

        public void AyarlariAta()
        {
            _connection1 = new MySqlConnection("server=localhost;userid=root;Database=egitim;");
            string sql = "insert into ayarlar values(0,'gericekil',1)";
            string sql1 = "insert into ayarlar values(0,'gunsayisi',24)";
            string sql2 = "insert into ayarlar values(0,'yanliscevap',1)";

            _connection1.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection1);
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql1;
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
            _connection1.Close();
        }

        public InitialCreate()
        {
            veritabaniOlustur();
            tablolariOlustur();
            adminOlustur();
            PuanlariAta();
            AyarlariAta();
        }



    }
}

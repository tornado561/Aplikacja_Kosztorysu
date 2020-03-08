using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace VP_10_Base_Project
{
    class Methods
    {
        public enum errorsHandler
        {
            all_ok = 200,
            empty_data = 101,
            wrong_data = 501,
        }

        string conString = "server=127.0.0.1; user = root; database = kosztorys";

        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@ PRZEDMIOTY @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@







        public DataTable pokazWszystko()
        {
            string querySelect = "SELECT * FROM przedmioty";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(querySelect))
                {


                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = connection;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "przedmioty";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }






        public DataTable szukajPrzedmiot(string kategoria)
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM przedmioty WHERE kategoria=@kategoria"))
                {


                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = connection;
                        sda.SelectCommand = cmd;
                        MySqlParameter sqlParameter = new MySqlParameter();
                        cmd.Parameters.AddWithValue("@kategoria", kategoria);


                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "przedmioty";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }



        public DataTable szukajKategorie()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT distinct kategoria FROM przedmioty"))
                {


                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = connection;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "przedmioty";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }



        public DataTable szukajPrzedmiotPoNazwie(string nazwa)
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM przedmioty WHERE nazwa=@nazwa"))
                {


                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = connection;
                        sda.SelectCommand = cmd;
                        MySqlParameter sqlParameter = new MySqlParameter();

                        sqlParameter = new MySqlParameter();
                        cmd.Parameters.AddWithValue("@nazwa", nazwa);
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "przedmioty";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }



        public int newRecord(string kategoria, string nazwa, string cena, string ilosc, string zdjecie, string link)
        {
            if (kategoria == string.Empty || nazwa == string.Empty || cena == string.Empty || ilosc == string.Empty || zdjecie == string.Empty || link == string.Empty)
            {
                return (int)errorsHandler.empty_data;
            }

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string addRecord = "INSERT INTO przedmioty (kategoria,nazwa,cena,ilosc,zdjecie,link) VALUES (@kategoria,@nazwa,@cena,@ilosc,@zdjecie,@link)";
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    MySqlParameter param = new MySqlParameter();

                    cmd.Parameters.AddWithValue("@kategoria", kategoria);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@nazwa", nazwa);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@cena", cena);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@ilosc", ilosc);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@zdjecie", zdjecie);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@link", link);

                    cmd.CommandText = addRecord;
                    cmd.ExecuteNonQuery();

                }

            }

            return (int)errorsHandler.all_ok;
        }




        public int updateRecord(int id, string kategoria, string nazwa, string cena, string ilosc, string zdjecie, string link)
        {


            using (MySqlConnection connection = new MySqlConnection(conString))
            {

                string updateClient = "UPDATE przedmioty SET kategoria = @kategoria , nazwa = @nazwa, cena = @cena , ilosc = @ilosc, zdjecie = @zdjecie, link = @link WHERE id = @id";
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    MySqlParameter param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@kategoria", kategoria);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@nazwa", nazwa);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@cena", cena);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@ilosc", ilosc);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@zdjecie", zdjecie);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@link", link);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.CommandText = updateClient;
                    cmd.ExecuteNonQuery();

                }

            }

            return (int)errorsHandler.all_ok;
        }


        public int deleteRecord(int id, string kategoria, string nazwa)
        {
            if (kategoria == string.Empty || nazwa == string.Empty)
            {
                return (int)errorsHandler.empty_data;
            }

            using (MySqlConnection connection = new MySqlConnection(conString))
            {

                string deleteClient = "DELETE FROM przedmioty WHERE kategoria = @kategoria AND nazwa = @nazwa AND id = @id";
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    MySqlParameter param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@kategoria", kategoria);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@nazwa", nazwa);

                    param = new MySqlParameter();
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.CommandText = deleteClient;
                    cmd.ExecuteNonQuery();

                }

            }

            return (int)errorsHandler.all_ok;
        }












    }
}


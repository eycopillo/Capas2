using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basededatos
{
    public class Basededatos
    {
        public static void insertar(string NombreC, string DepartamentoC)
        {
            string cadena = "Data Source = MSI\\PEPE;Initial Catalog = Consultoria_Alteña; Integrated Security = True";
            SqlConnection Conectarbd = new SqlConnection();

            try
            {
                SqlCommand cmd;
                Conectarbd.ConnectionString = cadena;
                Conectarbd.Open();
                cmd = new SqlCommand("Insert into Consultoria_Alteña.dbo.Capas (Nombre, Departamento) values('" + NombreC + "','" + DepartamentoC + ")", Conectarbd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Se se inserto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se conecto: " + ex.ToString());
            }
        }
        public static void insertar2(string Nombreoc, string Departamentooc)
        {
            string cadena = "Data Source = MSI\\PEPE;Initial Catalog = Consultoria_Alteña; Integrated Security = True";
            SqlConnection Conectarbd = new SqlConnection();

            try
            {
                SqlCommand cmd;
                Conectarbd.ConnectionString = cadena;
                Conectarbd.Open();
                cmd = new SqlCommand("Insert into Consultoria_Alteña.dbo.Capas (Nombre, Departamento) values('" + Nombreoc + "','" + Departamentooc + ")", Conectarbd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Se se inserto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se conecto: " + ex.ToString());
            }

        }
    }
}
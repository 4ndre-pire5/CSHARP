using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Empresa.DB
{
    // Helper para acesso a dados
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source = (localdb)\MSSQLLocalDB;
                        Initial Catalog = master; 
                        Integrated Security = True;     
                        Connect Timeout = 30; 
                        Encrypt = False; 
                        Trust Server Certificate = False; 
                        Application Intent = ReadWrite; 
                        Multi Subnet Failover = False";
            }
        }
        

    }
}

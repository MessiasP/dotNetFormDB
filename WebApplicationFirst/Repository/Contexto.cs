using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplicationFirst.Repository
{
    public class Contexto: DBContext
	{
        public Contexto()
			: base ("DefaultConnection")				
        {
			
        }
		
		public DBSet<Cliente> Cliente { get; set; }
		
    }
}
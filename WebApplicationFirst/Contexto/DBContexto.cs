using System;
using System.Collections.Generic;

// reconhecer o banco
using System.Data.Entity;

using System.Linq;
using System.Web;

// Recomhecer as classes do MEU PROJETO
using WebApplicationFirst.Models;

// F12 em cima do metodo chama o metodo

namespace WebApplicationFirst.Contexto {
    public class DBContexto : DbContext {

        // vai na classe mae e utiliza o metodo de uma classe q ja foi criada (metodo super em JAVA)
        public DBContexto(): base ("DefaultConnection") {

        }

        //E o que converte a class Cliente e cria o tabela para a classe
        public DbSet<ClienteNew> ClienteNews {
            get;
            set;
        }
    }
}
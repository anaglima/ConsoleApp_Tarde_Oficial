using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Endereco
    {
        private int Id;
        private string Cep;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cidade;

        public Endereco(int id, string cep, string rua, string numero, string bairro, string cidade)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
        public void AtualizarEndereco(string rua, string numero, string bairro)
        {
            setBairro(bairro);
            setNumero(numero);
            setRua(rua);
        }
        public string EnderecoCompleto()
        {
            return "Rua" + Rua + ", N° " + Numero + " Bairro " + Bairro + "Cidade" + Cidade;
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }

        public string getCep()
        {
            return Cep;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }

        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }

        public string getNumero()
        {
            return Numero;
        }
        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
    }
}

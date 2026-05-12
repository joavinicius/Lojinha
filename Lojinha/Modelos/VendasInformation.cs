using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Modelos
{
    internal class VendasInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private bool _faturado;
        public bool Faturado
        {
            get { return _faturado; }
            set { _faturado = value; }
        }

        private int _codigocliente;
        public int CodigoCliente
        {
            get { return _codigocliente; }
            set { _codigocliente = value; }
        }

        private int _codigoproduto;
        public int CodigoProduto
        {
            get { return _codigoproduto; }
            set { _codigoproduto = value; }
        }
    }
}
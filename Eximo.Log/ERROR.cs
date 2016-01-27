
///////////////////////////////////////////////////////////////////////////
//
// Generated by MyGeneration Version # (1.3.0.9) 
// 
// Template Creado por:
//
// eXimo - Consultora en Sistemas
//
///////////////////////////////////////////////////////////////////////////

using System;


namespace Eximo.Log
{
	public class ERROR
	{
		#region Private Properties
		
		private int _IdError;
        private DateTime _Fecha;
        private string _TargetSite;
		private string _Funcion;
		private string _Mensaje;
		private string _Modulo;
		private string _Tipo;
		private string _Componente;
		private int _Usuario;
		private string _Parametros;
        private string _Ip;
        private string _Host;
		
		#endregion
		
		#region Constructors
		
		public ERROR()
		{

		}

        public ERROR(int IdError, DateTime Fecha, string TargetSite, string Funcion, string Mensaje, string Modulo, string Tipo, string Componente
                    , int Usuario, string Parametros, string Ip, string Host)
		{
			_IdError = IdError;
            _Fecha = Fecha;
            _TargetSite = TargetSite;
			_Funcion = Funcion;
			_Mensaje = Mensaje;
			_Modulo = Modulo;
			_Tipo = Tipo;
			_Componente = Componente;
			_Usuario = Usuario;
			_Parametros = Parametros;
            _Ip = Ip;
            _Host = Host;
		}

		#endregion
		
		#region Properties
		
		public int IdError
		{
			get	{ return _IdError; }
			set	{ _IdError = value; }
		}

     

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string TargetSite
        {
            get { return _TargetSite; }
            set { _TargetSite = value; }
        }
		public string Funcion
		{
			get	{ return _Funcion; }
			set	{ _Funcion = value; }
		}
		
		public string Mensaje
		{
			get	{ return _Mensaje; }
			set	{ _Mensaje = value; }
		}
		
		public string Modulo
		{
			get	{ return _Modulo; }
			set	{ _Modulo = value; }
		}
		
		public string Tipo
		{
			get	{ return _Tipo; }
			set	{ _Tipo = value; }
		}
		
		public string Componente
		{
			get	{ return _Componente; }
			set	{ _Componente = value; }
		}
		
		public int Usuario
		{
			get	{ return _Usuario; }
			set	{ _Usuario = value; }
		}
		
		public string Parametros
		{
			get	{ return _Parametros; }
			set	{ _Parametros = value; }
		}

        public string Ip
        {
            get { return _Ip; }
            set { _Ip = value; }
        }

        public string Host
        {
            get { return _Host; }
            set { _Host = value; }
        } 
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Eximo.Log
{
    public static class LogError
    {
        /// <summary>
        ///     <para>
        ///     Guarda el detalle del error generado. Llena el objeto error y lo envia al implement
        ///     </para>
        ///     <para>param 1|"ex"(Exception) = Exception generada</para>
        ///     <para>param 2|"modulo"(string) = Texto que indica donde se produjo la exception</para>
        ///     <para></para>
        ///     <para>return (int)|Retorna un integer con el id de error guardado en la base de datos</para>
        /// </summary>
        /// <param name="ex">Exception generada</param>
        /// <param name="modulo(string)">Texto que indica donde se produjo la exception</param>
        /// <returns>Retorna un integer con el id de error guardado en la base de datos</returns>
        public static int ErrorAdd(Exception ex, string modulo)
        {
            ERROR error = new ERROR();

            error.Fecha = DateTime.Now;
           
            error.Funcion = ex.StackTrace;
            error.TargetSite = ex.TargetSite.ToString();
            error.Mensaje = ex.Message;
            error.Modulo = modulo;
            error.Tipo = ex.GetType().ToString();
            error.Componente = GetComponente();
            error.Parametros = GetStackTrace(ex);

            ERRORBus oErrorBus = new ERRORBus();

            return oErrorBus.ERRORAdd(error);
        }

        /// <summary>
        /// Obtiene el componente
        /// </summary>
        /// <returns></returns>
        private static string GetComponente()
        {
            Assembly asComponente;
            // Instantiate a target object.
            Int32 Integer1 = new Int32();
            Type Type1;
            // Set the Type instance to the target class type.
            Type1 = Integer1.GetType();
            // Instantiate an Assembly class to the assembly housing the Integer type.  
            asComponente = Assembly.GetAssembly(Integer1.GetType());
            // Return the name of the assembly that is calling the method.
            return Assembly.GetCallingAssembly().FullName.ToString();
        }

        /// <summary>
        /// Obtiene el Stacktrace de ls Excepcion
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static string GetStackTrace(Exception ex)
        {
            if (ex.InnerException != null)
            {
                return GetStackTrace(ex.InnerException);
            }
            else
            {
                return ex.Message;
            }
        }

    }
}

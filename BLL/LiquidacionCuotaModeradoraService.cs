﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        private static LiquidacionCuotaModeradoraRepository cuotaRepository = new LiquidacionCuotaModeradoraRepository();
        public LiquidacionCuotaModeradoraService()
        {
            cuotaRepository = new LiquidacionCuotaModeradoraRepository();
        }


        public static IEnumerable<LiquidacionCuotaModeradora> ListarContributivo()
        {
            return cuotaRepository.ListarContributivo();
        }

        public static IEnumerable<LiquidacionCuotaModeradora> ListarSubsidiado()
        {
            return cuotaRepository.ListarSubsidiado();
        }

        public int TotalizarContributivo()
        {
            return cuotaRepository.TotalizarContributivo();
        }

        public int TotalizarSubsidiado()
        {
            return cuotaRepository.TotalizarSubsidiado();
        }

        public int TotalizarTodos()
        {
            return cuotaRepository.TotalizarTodos();
        }

        public double ValorTotalLiquidacion()
        {
            return cuotaRepository.ValorTotalLiquidacion();
        }

        public double ValorTotalLiquidacionContributivo()
        {
            return cuotaRepository.ValorTotalLiquidacionContributivo();
        }

        public double ValorTotalLiquidacionSubsidiado()
        {
            return cuotaRepository.ValorTotalLiquidacionSubsidiado();
        }

        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            try
            {
                if (cuotaRepository.Buscar(liquidacion.Identificacion) == null)
                {
                    cuotaRepository.Guardar(liquidacion);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                else
                {
                    return $"El numero de liquidacion: {liquidacion.Identificacion} Ya se encuentra registrado en el sistema";
                }

            }
            catch (Exception e)
            {

                return "Error de Datos: " + e.Message;
            }
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                if (cuotaRepository.Buscar(identificacion) != null)
                {
                    cuotaRepository.Eliminar(identificacion);
                    return $"se elimino la liquidacion numero: {identificacion} correctamente";
                }
                return $"El numero de liquidacion no esta registrado en el sistema";
            }
            catch (Exception e)
            {
                return $"ERROR" + e.Message;
            }
        }
        public static IList<LiquidacionCuotaModeradora> ConsultarTodos()
        {
            return cuotaRepository.Consultar();
        }

        public RespuestaConsulta ConsultarConsultaGeneral()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                respuesta.liquidaciones = cuotaRepository.Consultar();
                if (respuesta.liquidaciones != null)
                {
                    respuesta.Mensaje = "LISTADO DE LIQUIDACIONES";
                }
                else
                {
                    respuesta.Mensaje = "NO HAY DATOS";
                }
            }
            catch (Exception e)
            {

                respuesta.Error = true;
                respuesta.Mensaje = $"ERROR" + e.Message;
            }
            return respuesta;
        }

        public string Modificar(LiquidacionCuotaModeradora liquidacion)
        {
            try
            {
                if (cuotaRepository.Buscar(liquidacion.Identificacion) != null)
                {
                    cuotaRepository.Modificar(liquidacion);
                    return $"la liquidacion numero: {liquidacion.Identificacion} ha sido modificada con exito!";

                }
                return $"El numero de liquidacion: {liquidacion.Identificacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public LiquidacionCuotaModeradora BuscarID(string identificacion)
        {
            try
            {
                return cuotaRepository.Buscar(identificacion);
            }
            catch (Exception e)
            {
                string mensaje = " ERROR" + e.Message;
                return null;
            }
        }

        public RespuestaBusqueda Buscar(string identificacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                respuesta.liquidacion = cuotaRepository.Buscar(identificacion);
                if (respuesta.liquidacion != null)
                {
                    respuesta.Mensaje = "Se encontro una liquidación, proceda...";
                }
                else
                {
                    respuesta.Mensaje = "No hay una liquidacion asociada al numero digitado, VERIFIQUE!";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "ERROR: " + e.Message;
                respuesta.liquidacion = null;
                return respuesta;
            }
        }

    }

    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public LiquidacionCuotaModeradora liquidacion { get; set; }
        public bool Error { get; set; }
    }

    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<LiquidacionCuotaModeradora> liquidaciones { get; set; }
        public bool Error { get; set; }
    }
}


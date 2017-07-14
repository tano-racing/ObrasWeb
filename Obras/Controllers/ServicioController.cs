using Obras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Obras.Controllers
{
    public class ServicioController : ApiController
    {
        ObrasEntities ctx = new ObrasEntities();

        [ActionName("Obras")]
        public IHttpActionResult Obras()
        {
            try
            {
                var listadoObras = ctx.Obras.Select(a => new
                {
                    idObra = a.idObra,
                    Nombre = a.nombre,
                    Direccion = a.direccion
                });

                return Json(new { Obras = listadoObras, Exitoso = true });
            }
            catch (Exception ex)
            {
                return Json(new { Mensaje = "Error : " + ex.Message, Exitoso = false });
            }

        }

        [ActionName("Capataces")]
        public IHttpActionResult Capataces()
        {
            try
            {
                var listadoCapataces = ctx.Capataces.Select(a => new
                {
                    idCapataz = a.idCapataz,
                    Nombre = a.nombre,

                });

                return Json(new { Capataces = listadoCapataces, Exitoso = true });
            }
            catch (Exception ex)
            {
                return Json(new { Mensaje = "Error : " + ex.Message, Exitoso = false });
            }

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstREST.Lib_Primavera.Model;
using FirstREST.Lib_Primavera;



namespace FlowerPow.Controllers
{
    public class ArtigosController : ApiController
    {
        //
        // GET: /Artigos/

        public IEnumerable<Artigo> Get()
        {
            return Comercial.ListaArtigos();
        }


        // GET api/artigo/5    
        public Artigo Get(string id)
        {
            Artigo artigo = Comercial.GetArtigo(id);
            if (artigo == null)
            {
                throw new HttpResponseException(
                  Request.CreateResponse(HttpStatusCode.NotFound));
            }
            else
            {
                return artigo;
            }
        }

    }
}

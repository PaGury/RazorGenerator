﻿using System.Web.Mvc;
using System.Web.WebPages;
using PrecompiledMvcViewEngine;

namespace PrecompiledMvcLibrary {

    public static class PreApplicationStartCode {
        private static bool _startMethodExecuted = false;

        public static void Start() {
            if (_startMethodExecuted == true) {
                return;
            }

            var engine = new PrecompiledMvcEngine(typeof(PreApplicationStartCode).Assembly);

            ViewEngines.Engines.Add(engine);

            // StartPage lookups are done by WebPages. 
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);

            _startMethodExecuted = true;
        }
    }
}
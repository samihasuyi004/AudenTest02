﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenQaTest

    {
        enum PropertyType

        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }

        public class PropertiesCollection
        {


            public static IWebDriver driver { get; set; }

        }

    }


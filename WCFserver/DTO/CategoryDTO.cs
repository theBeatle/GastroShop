﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFserver.DTO
{
    public class CategoryDTO
    {

            public int ID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }
            public IngredientDTO[] Ingredients { get; set; }
    }
}
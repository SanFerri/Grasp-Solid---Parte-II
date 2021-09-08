//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public double Total()
        {
            double Total = 0;
            foreach(Step step in this.steps)
                Total += step.Gasto();
            return Total;
        } 
        public StringBuilder GetRecipeText()
        {
            StringBuilder text = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                text.Append($"{step.Quantity} de '{step.Input.Description}' " + $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            text.Append($"Gasto total: {this.Total()}");
            return text;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Recipe : IPrintable
    {
        // Cambiado por OCP
        private IList<BaseStep> steps = new List<BaseStep>();

        public Product FinalProduct { get; set; }

        public void AddStep(Product input, double quantity, Equipment equipment, int time)
        {
            Step step = new Step(input, quantity, equipment, time);
            this.steps.Add(step);
        }

        // Agregado por OCP y Creator
        public void AddStep(string description, int time)
        {
            WaitStep step = new WaitStep(description, time);
            this.steps.Add(step);
        }

        public void RemoveStep(BaseStep step)
        {
            this.steps.Remove(step);
        }
        
        // Agregado por SRP
        public string GetTextToPrint()
        {
            string result = $"Receta de {this.FinalProduct.Description}:\n";
            foreach (BaseStep step in this.steps)
            {
                result += step.GetTextToPrint() + "\n";
            }

            result += $"Costo de producción: {this.GetProductionCost()}";
            return result;
        }

        // Agregado por Expert
        public double GetProductionCost()
        {
            double result = 0;
            foreach (BaseStep step in this.steps)
            {
                result += step.GetStepCost();
            }
            return result;
        }
    }
}
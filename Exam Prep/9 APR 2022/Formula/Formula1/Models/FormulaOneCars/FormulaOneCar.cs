﻿using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Models.FormulaOneCars
{
    public abstract class FormulaOneCar : IFormulaOneCar
    {
        private string model;
        private int horsepower;
        private double engineDisplacement;
        protected FormulaOneCar(string model, int horsepower, double engineDisplacement) 
        { 
            this.Model = model;
            this.Horsepower = horsepower;
            this.EngineDisplacement = engineDisplacement;
        }
        public string Model 
        { 
            get => model; 
            private set 
            { 
                if (value.Length < 3 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidF1CarModel, value));
                }
                model = value;
            } 
        }

        public int Horsepower 
        { 
            get => horsepower;
            private set 
            {
                if (value < 900 || value > 1050 ) 
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidF1HorsePower, value));
                }
                horsepower = value;
            }
        
        }

        public double EngineDisplacement
        {
            get => engineDisplacement;
            private set 
            {
                if (value < 1.6 || value > 2.00)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidF1EngineDisplacement,value));
                }
                engineDisplacement = value;
            }
        }

        public double RaceScoreCalculator(int laps)
        => this.EngineDisplacement / this.Horsepower * laps;
    }
}

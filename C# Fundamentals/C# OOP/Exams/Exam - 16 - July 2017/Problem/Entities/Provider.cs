﻿using System;
using System.Text;

public abstract class Provider : MineWorker
{
    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }

        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }

            this.energyOutput = value;
        }
    }

    public string RegisterStatus()
    {
        return $"Successfully registered {this.GetTypeName()} Provider - {base.Id}".Trim();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.GetTypeName()} Provider - {base.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }

    private string GetTypeName()
    {
        var type = this.GetType().Name;
        return type.Replace("Provider", string.Empty).Trim();
    }
}

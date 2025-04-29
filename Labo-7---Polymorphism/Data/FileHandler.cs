using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo_7___Polymorphism.Entities;

namespace Labo_7___Polymorphism.Data
{
    internal static class FileHandler
    {
        public static Machine[] ImportFile(string filePath)
        {
            using StreamReader reader = new StreamReader(filePath);
            reader.ReadLine(); // skip header columns
            List<Machine> machineList = [];
            while (!reader.EndOfStream)
            {
                string csvLine = reader.ReadLine();
                string[] valueArray = csvLine.Split(",");
                Machine machine;
                switch (valueArray[0])
                {
                    case "L":
                        machine = CreateLaserCutter(valueArray);
                        break;
                    case "R":
                        machine = CreateRouter(valueArray);
                        break;
                    case "G":
                        machine = CreateGeneral(valueArray);
                        break;
                    default:
                        continue;
                }
                machineList.Add(machine);
            }
            return machineList.ToArray();
        }

        private static General CreateGeneral(string[] parameterArray)
        {
            return new General(parameterArray[1]);
        }

        private static Router CreateRouter(string[] parameterArray)
        {
            double width = double.Parse(parameterArray[2]);
            double length = double.Parse(parameterArray[3]);
            double costPerMinute = double.Parse(parameterArray[4]);
            return new Router(parameterArray[1], width, length, costPerMinute);
        }

        private static LaserCutter CreateLaserCutter(string[] parameterArray)
        {
            double width = double.Parse(parameterArray[2]);
            double length = double.Parse(parameterArray[3]);
            double costPerMinute = double.Parse(parameterArray[4]);
            double accuracy = double.Parse(parameterArray[5]);
            return new LaserCutter(parameterArray[1], width, length, costPerMinute, accuracy);
        }
    }
}

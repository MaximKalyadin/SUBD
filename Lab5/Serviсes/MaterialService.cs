using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5.Interface;
using Lab5.Interface;
using Lab5.Models;

namespace Lab5.Serviсes
{
    public class MaterialService : ILogic<Material>
    {
        private static SubdLab5DataBase db = Program.db;

        public void Create(Material model)
        {
            var material = db.Materials.FirstOrDefault(c => c.Name_Material == model.Name_Material);
            if (material != null)
            {
                throw new Exception("Такой материал уже есть");
            }
            db.Materials.Add(model);
            db.SaveChanges();
        }

        public void Delete(Material model)
        {
            var material = db.Materials.FirstOrDefault(c => c.Name_Material == model.Name_Material);
            if (material == null)
            {
                throw new Exception("Такого материала нет");
            }
            db.Materials.Remove(model);
            db.SaveChanges();
        }

        public void Update(Material model)
        {
            var material = db.Materials.FirstOrDefault(c => c.Name_Material == model.Name_Material);
            if (material == null)
            {
                throw new Exception("Такого материала нет");
            }
            material.Name_Material = model.Name_Material;
            material.Sum = model.Sum;
            db.SaveChanges();
        }

        public List<Material> Read()
        {
            return db.Materials.ToList();
        }
    }
}

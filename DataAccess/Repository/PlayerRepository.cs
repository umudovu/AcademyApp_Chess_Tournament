using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class PlayerRepository : IRepository<Player>
    {
        public bool Create(Player entity)
        {
            try
            {
                DataContext.Players.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Update(Player entity)
        {
            try
            {
                Player IsExsist = GetOne(p => p.Id== entity.Id);
                IsExsist=entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Player entity)
        {
            try
            {
                DataContext.Players.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Player> GetAll(Predicate<Player> filter = null)
        {
            try
            {
                return filter==null ? DataContext.Players :
                DataContext.Players.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Player GetOne(Predicate<Player> filter = null)
        {
            try
            {
                return filter==null ? DataContext.Players[0] :
                DataContext.Players.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}

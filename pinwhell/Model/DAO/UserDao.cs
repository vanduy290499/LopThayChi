﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAO
{
    public class UserDao
    {
        PinwhellDbContext db = null;
        public UserDao()
        {
            db = new PinwhellDbContext();
        }
        public IEnumerable<TaiKhoan> ListAllPaging(int page, int pageSize)
        {
            return db.TaiKhoan.OrderBy(x => x.NgayTao).ToPagedList(page, pageSize);
        }


        public TaiKhoan GetById(string userName)
        {
            return db.TaiKhoan.SingleOrDefault(x => x.Username == userName);
        }

        public long Insert(TaiKhoan entity)
        {
            db.TaiKhoan.Add(entity);
            db.SaveChanges();
            return entity.MaTK;
        }

        public bool Deleted(int id)
        {
            try
            {
                var user = db.TaiKhoan.Find(id);
                db.TaiKhoan.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Update(TaiKhoan entity)
        {
            try
            {
                var user = db.TaiKhoan.Find(entity.MaTK);
                user.Hoten = entity.Hoten;
                user.Email = entity.Email;
                user.Fb = entity.Fb;
                user.DiaChi = entity.DiaChi;
                user.Quyen = entity.Quyen;
                user.SDT = entity.SDT;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public TaiKhoan ViewDetail(int id)
        {
            return db.TaiKhoan.Find(id);
        }

        public bool Login(string userName, string passWord)
        {
            var result = db.TaiKhoan.Count(x => x.Username == userName && x.Password == passWord);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Usuario 
    {
        private string email;
        private string senha;
        private int ID;
        private bool status;
        private List<int> Chats;
        private int IdImg;

        public Usuario()
        {
            ID = 0;
            IdImg = 0;
            SetStatus(false);
            Chats = new List<int>();
        }
       
        public string GetEmail()
        {
            return email;
        }

        public string GetSenha()
        {
            return senha;
        }

        public bool SetEmail(string e)
        {
            if (BancodeDados.BuscarID(e) != 0) return false;
            email = e;
            return true;
        }

        public void SetSenha(string p)
        {
            senha = BancodeDados.CriptografarSenha(p);
        }

        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }
        
        public void SetStatus(bool valor)
        {
            status = valor;
        }
        public bool GetStatus()
        {
            return status;
        }
        public void AdicionarChat(int id)
        {
            for (int i = 0; i < Chats.Count; i++) if (Chats[i] == id) return;
            Chats.Add(id);
        }

        public List<int> GetChats()
        {
            return Chats;
        }

        public void SetChats(List<int> lista)
        {
            Chats = lista;
        }

        public int GetIdImg()
        {
            return IdImg;
        }
        public void SetIdImg(int id)
        {
            IdImg = id;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_Shop_2
{
    public class Sacchetto_di_frutta:Prodotto
    {
        private int numeroFrutti;
        private string tipoFrutto;
        private double pesoSacchetto;
        private double pesoFrutto;


        public Sacchetto_di_frutta(string name, string description, double prezzo, double IVA, int numeroFrutti, double pesoSacchetto, string tipoFrutto):base(name,description,prezzo,IVA)
        {
            this.numeroFrutti = numeroFrutti;
            this.tipoFrutto = tipoFrutto;
            this.pesoSacchetto= pesoSacchetto;
            this.pesoFrutto = PesoFrutto();
        }

        public int GetNumeroFrutti()
        {
            return this.numeroFrutti;
        }

        public string GetTipoFrutto()
        {
            return this.tipoFrutto;
        }

        public double GetPesoSacchetto()
        {
            return this.pesoSacchetto;
        }

        
        public void AggiungiFrutta(int numeroFrutti)
        {
            double prezzoSingoloFrutto = this.GetPrezzo() / this.numeroFrutti;
            this.numeroFrutti = this.numeroFrutti + numeroFrutti;
            this.pesoSacchetto = this.pesoSacchetto + (numeroFrutti * this.pesoFrutto);
            double prezzoAggiornato = prezzoSingoloFrutto * this.numeroFrutti;
            this.SetPrezzo(prezzoAggiornato);
        }

        private double PesoFrutto()
        {
            double pesofrutto = this.pesoSacchetto / this.numeroFrutti;
            return pesofrutto;
        }
    }
}
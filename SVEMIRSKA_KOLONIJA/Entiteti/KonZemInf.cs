﻿// Fajl: Entiteti/KonZemInf.cs
namespace SVEMIRSKA_KOLONIJA.Entiteti
{
    public class KonZemInf
    {
        public virtual int Id { get; protected set; }
        public virtual string KontaktInformacija { get; set; }
        public virtual KontaktNaZemlji PripadaKontaktu { get; set; }
    }
}
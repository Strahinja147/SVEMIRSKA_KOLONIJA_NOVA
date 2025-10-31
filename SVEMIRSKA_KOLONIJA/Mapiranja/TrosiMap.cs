﻿using FluentNHibernate.Mapping;
using SVEMIRSKA_KOLONIJA.Entiteti;

namespace SVEMIRSKA_KOLONIJA.Mapiranja
{
    class TrosiMap : ClassMap<Trosi>
    {
        public TrosiMap()
        {
            Table("TROSI");
            Id(x => x.Id, "TROSI_ID").GeneratedBy.Native("SEQ_TROSI");

            Map(x => x.DnevniProsek, "DNEVNI_PROSEK");
            Map(x => x.KriticnaVrednost, "KRITICNA_VREDNOST");

            References(x => x.Sektor, "SEKTOR_ID");
            References(x => x.Resurs, "RESURS_ID");
        }
    }
}
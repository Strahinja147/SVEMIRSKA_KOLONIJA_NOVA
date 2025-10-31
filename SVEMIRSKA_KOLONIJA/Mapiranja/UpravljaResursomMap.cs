﻿using FluentNHibernate.Mapping;
using SVEMIRSKA_KOLONIJA.Entiteti;

namespace SVEMIRSKA_KOLONIJA.Mapiranja
{
    public class UpravljaResursomMap : ClassMap<UpravljaResursom>
    {
        public UpravljaResursomMap()
        {
            Table("UPRAVLJA_RESURSOM");

            Id(x => x.Id, "UPRAVLJA_RESURSOM_ID").GeneratedBy.Native("SEQ_UPRAVLJA_RESURSOM");

            References(x => x.Stanovnik, "STANOVNIK_ID");
            References(x => x.Resurs, "RESURS_ID");
        }
    }
}
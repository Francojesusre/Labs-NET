using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab02
{
    class ManejadorArchivoXml:ManejadorArchivo
    {
        protected DataSet ds;
        public override DataTable getTabla()
        {
            ds = new DataSet();
            ds.ReadXml("agenda.xml");
            return ds.Tables["contactos"];

        }
        public override void aplicaCambios()
        {
            ds.WriteXml("agenda.xml");
            ds.WriteXml("agendaconschema.xml", XmlWriteMode.WriteSchema);
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaHotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_reservas
    {
        public int id { get; set; }
        public System.DateTime dt_cadastro { get; set; }
        public Nullable<System.DateTime> dt_entrada { get; set; }
        public System.DateTime dt_inicio { get; set; }
        public System.DateTime dt_termino { get; set; }
        public Nullable<System.DateTime> dt_saida { get; set; }
        public int fk_quarto { get; set; }
        public int fk_cliente { get; set; }
        public Nullable<bool> ativo { get; set; }
    }
}
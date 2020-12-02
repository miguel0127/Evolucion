
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace TrabajoFinalWeb.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Producto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Producto()
    {

        this.PPS = new HashSet<PP>();

        this.Productos_Pedidos = new HashSet<Productos_Pedidos>();

    }


    public int ID { get; set; }

    public string Nombre { get; set; }

    public int IdTipoProducto { get; set; }

    public decimal Precio { get; set; }

    public string Descripcion { get; set; }

    public string imagen { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PP> PPS { get; set; }

    public virtual TipoProducto TipoProducto { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Productos_Pedidos> Productos_Pedidos { get; set; }

}

}

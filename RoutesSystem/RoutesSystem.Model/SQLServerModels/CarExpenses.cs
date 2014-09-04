namespace RoutesSystem.Model.SQLServerModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CarExpenses
    {
        [Key]
        public int Id { get; set; }

        public int CarEntry { get; set; }

        public DateTime Date { get; set; }

        public decimal Cost { get; set; }
    }
}

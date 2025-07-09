using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace PetInsuranceProject.Server.Models;



public class QuickQuoteModel
{

    public Guid QuoteId { get; set; }
    public string QuoteUserFirstName { get; set; }  
    public string QuoteUserLastName { get; set; }
    public string QuoteEmail { get; set; }


    //Pet
    public Guid PetId { get; set; }
    [ForeignKey("PetId")]

    public PetModel Pet { get; set; }





}






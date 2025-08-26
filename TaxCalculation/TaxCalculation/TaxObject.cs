using System;
using System.Security.Cryptography.X509Certificates;

namespace TaxCalculation
{
    

    public enum VatGroup                                            //predefined tax groups
    {
        Other,                                                      //25%, default
        Foodstuffs,                                                 //15%
        PassengerTransport,                                         //12%
        Accommodation,                                              //12%
        EntertainmentTickets,                                       //12%
        ActivityCentreAdmission                                     //12%
    }

    public sealed class TaxObject                                   //TaxObject class with three properties
    {
        public decimal ValueWithoutTax { get; set; }                //value without tax
        public VatGroup ValueAddedTaxGroup { get; set; }            //tax group, chosen from enum
        public decimal ValueAddedTax { get; set; }                  //value of the tax itself

        public decimal TotalWithTax => 
            ValueWithoutTax + ValueAddedTax;                        //total value with tax included

        public static decimal RateFor(VatGroup group)               //method to get the tax rate for a given tax group
        {
            return group switch
            {
                VatGroup.Foodstuffs => 0.15m,
                VatGroup.PassengerTransport => 0.12m,
                VatGroup.Accommodation => 0.12m,
                VatGroup.EntertainmentTickets => 0.12m,
                VatGroup.ActivityCentreAdmission => 0.12m,
                VatGroup.Other => 0.25m,
                _ => 0.25m
            };
        }
        public static TaxObject FromBase(decimal baseValue, VatGroup group) 
        { 
            var rate = RateFor(group);
            var vat = baseValue * rate;
            return new TaxObject
            {
                ValueWithoutTax = baseValue,
                ValueAddedTaxGroup = group,
                ValueAddedTax = vat
            };

        }



    }




}

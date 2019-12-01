using System;

namespace CodeNextZen_DesignPattern
{
    /*
     * Design Pattern:          Code        (Factory, Iterator, Singleton etc.)
     * Architecture Pattern:    Diagram     (MVC, MVP, MVVM, Gang of 4 etc.)
     * Architecture Style:      Principles  (REST, SOA, IOC etc.)
     * 
     * 
     * Design Pattern are time tested solution for software architecture problems.(best practices for an OOPs Principles).
     * 
     * CoolShop projects:- "CoolShop" is a large retail shopping mall which has a chain of mall's in Mumbai and pune city.
     *                      The Company Managements wants a simple customer management system for their retail shops with 
     *                      the following features, the company has decided to launch the project in phases.
     *                      
     *                      So in the first phase they just want to capture the customer information. Below is the requirement in more details:-
     *                      
     *                      1. Application would be capturing 5 fields for now Customer Name, Phone Number,
     *                         Bill Amount, Bill date and Customer address.
     *                      2. In phase 1 two types of customer data are collected. One is the lead and the other is a customer.
     *                         A lead is a person who comes to cool shop but does not buy anything. He just enquires and goes 
     *                         
     * Noun: Entities
     * Pronoun: Properties
     * Verb: Methods
     */
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDemo s = SingletonDemo.getInstance;
            s.Print("First");
            s.Print("Second");
        }
    }
}

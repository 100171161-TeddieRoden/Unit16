/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package app05.bank;
import java.io.*;
/**
 *
 * @author 100171161
 */
public class Bank {
 
        // Attributes of bank
        private String name;

        // Constructor of this class
        Bank(String name)
        {
            // this keyword refers to current instance itself
            this.name = name;
        }

        // Method of Bank class
        public String getBankName()
        {
            // Returning name of bank
            return this.name;
        }
    }


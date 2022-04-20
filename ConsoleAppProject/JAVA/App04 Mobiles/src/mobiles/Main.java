/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package mobiles;

/**
 *
 * @author 100171161
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Samsung s = new Samsung();
        Nokia n = new Nokia();
        Xiaomi x = new Xiaomi();
        
        s.setandroid_version("Android Pie");
        s.setColor("Black");
        s.setCost(3000);
        s.setRAM("4GB");
        System.out.println("Samsung mobile details");
        System.out.println("Cost: "+s.getCost());
        System.out.println("Colour: "+s.getColor());
        System.out.println("RAM: "+s.getRAM());
        System.out.println("Android version: "+s.getandroid_version());
        
        n.setColor("Silver");
        n.setCost(40000);
        n.setRAM("4GB");
        n.setandroid_version("Andoid marshmelo");

        x.setColor("Red");
        x.setCost(50000);
        x.setRAM("6GB");
        x.setandroid_version("Andoid Kitkat");

        System.out.println("Samsung Details: ");
        System.out.println("Colour: "+s.getColor());
        System.out.println("Cost: "+ s.getCost());
        System.out.println("RAM"+ s.getRAM());
        System.out.println("RAM: "+ s.getRAM());
        System.out.println(" Samsung android version: " + s.getandroid_version());

        System.out.println("Nokia Details: ");
        System.out.println("Colour: "+n.getColor());
        System.out.println("Cost: "+ n.getCost());
        System.out.println("RAM: "+ n.getRAM());
        System.out.println(" Nokia android version: " + n.getandroid_version());

        System.out.println("Xiaomi Details: ");
        System.out.println("Colour: "+x.getColor());
        System.out.println("Cost: "+ x.getCost());
        System.out.println("RAM: "+ x.getRAM());
        System.out.println(" Xiaomi android version: " + x.getandroid_version());
    }
    
}

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
    s.setColor("Black");
    s.setCost(30000);
    s.setRAM("4GB");
    s.setandroid_version("Android Pie");
    
        System.out.println("Samsung mobile details");
        System.out.println("Cost: "+s.getCost());
        System.out.println("Color: "+s.getColor());
        System.out.println("RAM: "+s.getRAM());
        System.out.println("Android version: "+s.getandroid_version());
        
    }
    
}

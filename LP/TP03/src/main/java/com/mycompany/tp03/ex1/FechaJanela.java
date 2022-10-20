/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.tp03.ex1;
import java.awt.event.*;
/**
 *
 * @author gabri
 */
class FechaJanela extends WindowAdapter {
    public void windowClosing(WindowEvent e)
    {
        System.exit(0);
    }
}
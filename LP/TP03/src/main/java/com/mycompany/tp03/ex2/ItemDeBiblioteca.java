/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.tp03.ex2;

/**
 *
 * @author Guilherme
 */
public interface ItemDeBiblioteca{
  public int diasemprestimo = 7;

  abstract public boolean getEmprestado();
  abstract public String getLocalizacao();
  abstract public void Empresta();
  abstract public void Devolve();
}

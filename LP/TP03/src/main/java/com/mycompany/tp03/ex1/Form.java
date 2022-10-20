/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.tp03.ex1;
import java.awt.*;
import java.awt.event.*;
import javax.swing.JOptionPane;
/**
 *
 * @author aluno
 */
public class Form extends Frame implements ActionListener {
    private final Label lA = new Label("A: ");
    private final Label lB = new Label("B: ");
    private final Label lSoma = new Label("Soma: ");
    private final Label lSubtracao = new Label("Substracao: ");
    private final Label lMultiplicacao = new Label("Multiplicação: ");
    private final Label lDivisao = new Label("Divisão: ");
    private final TextField iA = new TextField();
    private final TextField iB = new TextField();
    private final TextField iSoma = new TextField();
    private final TextField iSubtracao = new TextField();
    private final TextField iMultiplicacao = new TextField();
    private final TextField iDivisao = new TextField();
    private final Button bLimpar = new Button("Limpar");
    private final Button bCalcular = new Button("Calcular");
    private final Button bSair = new Button("Sair");

Form(String titulo, int largura, int altura) {
        super(titulo);
        setSize(largura,altura);
        setLocation(550, 300);
        setLayout(new BorderLayout());
        setBackground(Color.GREEN);
        addWindowListener(new FechaJanela());
        
        Panel p1 = new Panel();
        GridLayout layoutP1 = new GridLayout(6,1);
        p1.setLayout(layoutP1);
        p1.add(lA);
        p1.add(iA);
        p1.add(lB);
        p1.add(iB);
        p1.add(lSoma);
        p1.add(iSoma);
        p1.add(lSubtracao);
        p1.add(iSubtracao);
        p1.add(lMultiplicacao);
        p1.add(iMultiplicacao);
        p1.add(lDivisao);
        p1.add(iDivisao);
        
        add(p1, BorderLayout.CENTER);
        
        Panel p2 = new Panel();
        GridLayout layoutP2 = new GridLayout();
        p2.setLayout(layoutP2);
        
        bLimpar.addActionListener(this);
        bCalcular.addActionListener(this);
        bSair.addActionListener(this);
        p2.add(bLimpar);
        p2.add(bCalcular);
        p2.add(bSair);
        
        add(p2, BorderLayout.SOUTH);
        
    }

    public void actionPerformed(ActionEvent e)
    {
        if (e.getSource()== bSair)
        {
            System.exit(0);
        } else if (e.getSource()== bLimpar){
            iA.setText("");
            iB.setText("");
            iSoma.setText("");
            iSubtracao.setText("");
            iMultiplicacao.setText("");
            iDivisao.setText("");
        } else if (e.getSource()== bCalcular){
            
                int a, b;
                String soma, subtracao, mult, divisao;
            try{
                a = Integer.valueOf(iA.getText());
                b = Integer.valueOf(iB.getText());

                soma = String.valueOf(a + b);
                subtracao = String.valueOf(a - b);
                mult = String.valueOf( a * b);
                divisao = String.valueOf(a / b);

                iSoma.setText(soma);
                iSubtracao.setText(subtracao);
                iMultiplicacao.setText(mult);
                iDivisao.setText(divisao);
            } catch (Exception err){
                JOptionPane.showMessageDialog(null, "Digite apenas número inteiros", "ERRO",JOptionPane.ERROR_MESSAGE);
            }
        }
    }
}

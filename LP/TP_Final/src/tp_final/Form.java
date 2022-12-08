/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_final;

import java.awt.*;
import java.awt.event.*;
import javax.swing.JOptionPane;
import com.google.gson.*;

/**
 *
 * @author gabri
 */
public class Form extends Frame implements ActionListener {
    private final Label lNome = new Label("Nome: ");
    private final Label lIdade = new Label("Idade: ");
    private final Label lPeso = new Label("Peso: ");
    private final Label lAltura = new Label("Altura: ");
    private final Label lObjetivo = new Label("Objetivo: ");
    private final TextField iNome = new TextField();
    private final TextField iIdade = new TextField();
    private final TextField iPeso = new TextField();
    private final TextField iAltura = new TextField();
    private final TextField iObjetivo = new TextField();
    private final Button bIncluir = new Button("Incluir");
    private final Button bLimpar = new Button("Limpar");
    private final Button bDados = new Button("Apresenta Dados");
    private final Button bSair = new Button("Sair");
    private final Conexao con = new Conexao();
    private Alunos a = new Alunos();

Form(String titulo, int largura, int altura) {
        super(titulo);
        setSize(largura,altura);
        setLocation(550, 300);
        BorderLayout layout = new BorderLayout();
        setLayout(layout);
        setBackground(Color.WHITE);
        addWindowListener(new FechaJanela());
        
        //con.verificarConexao();
        
        Panel p1 = new Panel();
        GridLayout layoutP1 = new GridLayout(5, 2);
        p1.setLayout(layoutP1);
        
        p1.add(lNome);
        p1.add(iNome);
        p1.add(lIdade);
        p1.add(iIdade);
        p1.add(lPeso);
        p1.add(iPeso);
        p1.add(lAltura);
        p1.add(iAltura);
        p1.add(lObjetivo);
        p1.add(iObjetivo);
        
        add(p1, BorderLayout.CENTER);
        
        
        Panel p2 = new Panel();
        GridLayout layoutP2 = new GridLayout();
        p2.setLayout(layoutP2);
        
        bIncluir.addActionListener(this);
        bLimpar.addActionListener(this);
        bDados.addActionListener(this);
        bSair.addActionListener(this);
        p2.add(bIncluir);
        p2.add(bLimpar);
        p2.add(bDados);
        p2.add(bSair);
        
        add(p2, BorderLayout.SOUTH);
        
    }

    public void actionPerformed(ActionEvent e)
    {
        if (e.getSource() == bIncluir){
          try{
            String nome, objetivo;
            int idade;
            float peso, altura;
            
            nome = iNome.getText();
            idade = Integer.parseInt(iIdade.getText());
            peso = Float.parseFloat(iPeso.getText());
            altura = Float.parseFloat(iAltura.getText());
            objetivo = iObjetivo.getText();
            
            con.criarAluno(nome, idade, peso, altura, objetivo);
          } catch(Exception excecao){
            JOptionPane.showMessageDialog(null,"Preencha todos os campos", "ERRO",JOptionPane.ERROR_MESSAGE);
          }
        } 
        
        if (e.getSource() == bLimpar){
            iNome.setText("");
            iPeso.setText("");
            iIdade.setText("");
            iAltura.setText("");
            iObjetivo.setText("");
        } 
        
        if (e.getSource() == bDados)
        {
            a.setAlunos(con.pesquisa().getAlunos());
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            String saveJson = gson.toJson(a);
          
            JOptionPane.showMessageDialog(this, saveJson);
        }
        
        if (e.getSource() == bSair){
            System.exit(0);
        }
    }
}


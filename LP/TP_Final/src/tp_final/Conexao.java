/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_final;
import java.sql.*;
/**
 *
 * @author gabri
 */
public class Conexao {
    private final String url = "jdbc:mysql://127.0.0.1:3306/tpfinal";
    private final String usuario = "root";
    private final String senha = "123456";
    
    public void verificarConexao(){
        try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        System.out.println ("Conexao OK");

        DatabaseMetaData db = con.getMetaData();
        System.out.println("Conectado a "+db.getURL());
        System.out.println("Conexao     "+db.getConnection());
        System.out.println("Driver      "+db.getDriverName());
        System.out.println("Usuario     "+db.getUserName());
        System.out.println("----------------------------------");

        con.close();
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
      }
    }
    
    public void criarAluno(String nome, int idade, float peso, float altura, String objetivo){
      try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        
        String st = "INSERT INTO alunos(nome_aluno, idade_aluno, peso_aluno, altura_aluno, objetivo_aluno) VALUES (?, ?, ?, ?, ?)";
        PreparedStatement ps = con.prepareStatement(st);
        ps.setString(1, "" + nome + "");
        ps.setString(2, "" + idade + "");
        ps.setString(3, "" + peso + "");
        ps.setString(4, "" + altura + "");
        ps.setString(5, "" + objetivo + "");
       
        ps.executeUpdate();
        
        con.close();
        
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
      }
    }
    
    public Alunos pesquisa() {
      try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        
        String st = "SELECT * FROM alunos";
        PreparedStatement ps = con.prepareStatement(st);
        ResultSet rs = ps.executeQuery();

        String nome, objetivo;
        int idade;
        float peso, altura;
        
        Alunos a = new Alunos();
        
        while(rs.next()){

            nome = rs.getString("nome_aluno");
            idade = Integer.parseInt(rs.getString("idade_aluno"));
            peso = Float.parseFloat(rs.getString("peso_aluno"));
            altura = Float.parseFloat(rs.getString("altura_aluno"));
            objetivo = rs.getString("objetivo_aluno");
            Aluno aux = new Aluno(nome, idade, peso, altura, objetivo);

            a.adicionar(aux);
        }

        con.close();
        
        
        return a;
        
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
        Alunos a = new Alunos();
        return a;
      }
    }
    
    public void LimparAlunos(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");

            Connection con;
            con = DriverManager.getConnection(url, usuario, senha);

            String st = "DELETE FROM alunos";
            PreparedStatement ps = con.prepareStatement(st);
            ps.execute();
            

            con.close();
       
        } catch(Exception e) {
        System.out.println("Erro: " + e.getMessage());
      }
    }
}

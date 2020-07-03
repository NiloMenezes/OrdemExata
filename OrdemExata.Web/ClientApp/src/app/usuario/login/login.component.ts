import { Component, OnInit } from "@angular/core"
import { Router, ActivatedRoute } from "@angular/router";
import { Usuario } from "../../modelo/usuario";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";


@Component({
  selector: "app-ajuda",
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;
  public blocoErro: boolean;
  public mensagem: string;
  public spinner: boolean;

  constructor(private router: Router, private activateRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
    
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activateRouter.snapshot.queryParams['returnUrl'];
  }

  entrar() {
    this.mensagem = "";
    this.blocoErro = false;
    this.spinner = true;

    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      usuario_json => {
        this.usuarioServico.usuario = usuario_json;
        if (this.returnUrl == null)
          this.router.navigate(['/']);
        else
          this.router.navigate([this.returnUrl]);
      },
      err => {
        this.mensagem = err.error;
        this.blocoErro = true;
        this.spinner = false;
      }
    );   
  }

  fecharBlocoErro() {
    this.blocoErro = false;
  }
}

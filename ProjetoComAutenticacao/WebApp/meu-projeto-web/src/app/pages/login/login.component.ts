import {Component, OnDestroy, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {ActivatedRoute, Router} from "@angular/router";
import {AlertService} from "../../services/alert.service";
import {AutenticacaoService} from "../../services/autenticacao.service";
import Pessoa from "../../models/pessoa.model";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {

  public formulario: FormGroup;
  public formSubmetido: boolean = false;

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public activatedRoute: ActivatedRoute,
    public alertService: AlertService,
    public autenticacaoService: AutenticacaoService,
  ) { }

  public ngOnInit(): void {
    document.title = 'Login';

    if(this.autenticacaoService.estaLogado()) {
      this.redirecionarParaMenuPrincipal();
    }

    this.inicializarConfigForm();
  }

  public ngOnDestroy(): void {
  }

  public submeterForm(): void {
    this.formSubmetido = true;

    if(this.formulario.invalid) {
      return;
    }

    let dadosLogin = this.formulario.getRawValue();

    this.chamarApiParaEfetuarLogin(dadosLogin);
  }

  private inicializarConfigForm(): void {
    this.formulario = this.formBuilder.group({
      nomeUsuarioOuEmail: [null, [Validators.required, Validators.maxLength(150)]],
      senha: [null, [Validators.required, Validators.maxLength(150)]]
    });
  }

  public chamarApiParaEfetuarLogin(dadosLogin: any): void {
    this.autenticacaoService.login(dadosLogin).subscribe(resposta => {

      if(resposta != null) {
        this.autenticacaoService.iniciarSessao(resposta.token, resposta.dataExpiracao, resposta.nomeUsuario, resposta.email, resposta.tipoPerfil, resposta.idUsuario);
        this.alertService.showToastrSuccess('Login efetuado com sucesso');
        this.redirecionarParaMenuPrincipal();
      } else {
        this.alertService.showToastrError('Erro ao efetuar login');
      }

    }, exception => {
      let mensagemErro = typeof(exception?.error) == "string" ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

  private redirecionarParaMenuPrincipal(): void {
    this.router.navigate(['/principal']);
  }

}

import {Injectable} from "@angular/core";
import {ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot} from "@angular/router";
import {AutenticacaoService} from "../services/autenticacao.service";

@Injectable()
export class UsuarioLogadoGuard implements CanActivate {

  constructor(
    private readonly router: Router,
    private readonly autenticacaoService: AutenticacaoService
  ) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {

    if(this.autenticacaoService.estaLogado()) {
      return true;
    } else {
      this.autenticacaoService.deslogarERedirecionarParaLogin();
      return false;
    }

  }
}

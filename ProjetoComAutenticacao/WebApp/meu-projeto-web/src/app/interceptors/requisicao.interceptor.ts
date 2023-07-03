import {HttpEvent, HttpHandler, HttpInterceptor, HttpParams, HttpRequest} from "@angular/common/http";
import {Observable} from "rxjs";
import {Injectable} from "@angular/core";
import {tap} from "rxjs/operators";
import {Router} from "@angular/router";
import {AutenticacaoService} from "../services/autenticacao.service";
import {AlertService} from "../services/alert.service";

@Injectable()

export class AuthInterceptor implements HttpInterceptor{

  constructor(
    private readonly autenticacaoService: AutenticacaoService,
    private alertService: AlertService,
    private router: Router
  ) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    if (!req.headers.has('Content-Type') && !req.reportProgress) {
      req = req.clone({
        headers: req.headers.set('Content-Type', 'application/json')
      });
    }

    if (this.autenticacaoService.estaLogado()) {
      req = this.adicionarTokenLoginNaRequisicao(req);
    }

    if (req.method == "GET") {
      req = req.clone({
        params: this.removeNullValuesFromQueryParams(req.params)
      });
    }

    return next.handle(req).pipe(
      tap((event: any) => {
        },error => {
        }
      ));
  }

  private adicionarTokenLoginNaRequisicao(request: HttpRequest<any>): HttpRequest<any> {
    return request.clone({
      headers: request.headers.set("Authorization", this.autenticacaoService.obterTokenLogin())
    });
  }

  private removeNullValuesFromQueryParams(params: HttpParams) {
    const paramsKeysAux = params.keys();
    paramsKeysAux.forEach((key) => {
      const value = params.get(key);
      if (value === null || value === undefined || value === '') {
        params['map'].delete(key);
      }
    });

    return params;
  }

}

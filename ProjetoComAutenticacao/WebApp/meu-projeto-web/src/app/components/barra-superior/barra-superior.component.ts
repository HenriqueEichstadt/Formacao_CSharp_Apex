import { Component, OnInit } from '@angular/core';
import {AutenticacaoService} from "../../services/autenticacao.service";

@Component({
  selector: 'app-barra-superior',
  templateUrl: './barra-superior.component.html',
  styleUrls: ['./barra-superior.component.css']
})
export class BarraSuperiorComponent implements OnInit {

  constructor(
    public autenticacaoService: AutenticacaoService
  ) { }

  public ngOnInit(): void {
  }

  public logout(): void {
    this.autenticacaoService.deslogarERedirecionarParaLogin();
  }

}

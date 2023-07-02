import { Component, Input, OnInit } from '@angular/core';
import { ValidationErrors } from '@angular/forms';

@Component({
  selector: 'validator',
  templateUrl: './validator.component.html',
  styleUrls: ['./validator.component.css']
})
export class ValidatorComponent implements OnInit {
  @Input() errors: ValidationErrors;
  @Input() errorsFormularioPersonalizado: ValidationErrors;
  @Input() formSubmitted = false;

  public formatoCpf: string = "000.000.000-00";

  constructor() {

  }

  public ngOnInit(): void {

  }

}

import { Injectable } from '@angular/core';
import { ToastrService } from "ngx-toastr";
import Swal from 'sweetalert2/dist/sweetalert2.js';
//declare var swal: any;

@Injectable({
  providedIn: 'root'
})

export class AlertService {

  constructor(private toastr: ToastrService) { }

  public alert({title = 'Atenção', text = '', type = 'info', showCancelButton = false, confirmButtonColor = '#2E6DA4', confirmButtonText = 'Ok',  cancelButtonColor = '#D43F3A', cancelButtonText = 'Não', closeOnConfirm = true, html = false, timer = null, fn = null, fnCancel = null}): void{
    Swal.fire({
        title: title,
        text: text,
        type: type,
        showCancelButton: showCancelButton,
        confirmButtonColor: confirmButtonColor,
        confirmButtonText: confirmButtonText,
        cancelButtonText: cancelButtonText,
        cancelButtonColor: cancelButtonColor,
        closeOnConfirm: closeOnConfirm,
        html: html,
        reverseButtons: true,
        timer: timer
      }).then((result) => {
      if (result.value) {
        fn();
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        fnCancel();
      }
    })
  }

  public alertConfirm({title = 'Atenção', text = '', type = 'info', showCancelButton = true, confirmButtonColor = '#2E6DA4', confirmButtonText = 'Sim',  cancelButtonColor = '#D43F3A', cancelButtonText = 'Não', closeOnConfirm = true, html = false, timer = null, fn = null, fnCancel = null}): void{
    this.alert({title: title, text: text, type: type, showCancelButton: showCancelButton, confirmButtonColor: confirmButtonColor, confirmButtonText: confirmButtonText, cancelButtonColor: cancelButtonColor, cancelButtonText: cancelButtonText, closeOnConfirm: closeOnConfirm, html: html, timer: timer, fn: fn, fnCancel: fnCancel});
  }

  public alertSuccess({title = 'Sucesso!', text = '', type = 'success', showCancelButton = false, confirmButtonColor = '#2E6DA4', confirmButtonText = 'Ok', cancelButtonColor = '#D43F3A', cancelButtonText = 'Não', closeOnConfirm = true, html = false, timer = null, fn = null, fnCancel = null}): void{
    this.alert({title: title, text: text, type: type, showCancelButton: showCancelButton, confirmButtonColor: confirmButtonColor, confirmButtonText: confirmButtonText, cancelButtonColor: cancelButtonColor, cancelButtonText: cancelButtonText, closeOnConfirm: closeOnConfirm, html: html, timer: timer, fn: fn, fnCancel: fnCancel});
  }

  public alertErro({title = 'erro!', text = '', type = 'error', showCancelButton = false, confirmButtonColor = '#2E6DA4', confirmButtonText = 'Ok', cancelButtonColor = '#D43F3A', cancelButtonText = 'Não', closeOnConfirm = true, html = false, timer = null, fn = null, fnCancel = null}): void{
    this.alert({title: title, text: text, type: type, showCancelButton: showCancelButton, confirmButtonColor: confirmButtonColor, confirmButtonText: confirmButtonText, cancelButtonColor: cancelButtonColor, cancelButtonText: cancelButtonText, closeOnConfirm: closeOnConfirm, html: html, timer: timer, fn: fn, fnCancel: fnCancel});
  }

  private static createOptionsForToaster(options: any) {
    options = options || {};
    let opt = {
      closeButton: options.closeButton || false,
      timeOut: options.timeOut || 5000,
      extendedTimeOut: options.extendedTimeOut || 1000,
      disableTimeOut: options.disableTimeOut || false,
      easing: options.disableTimeOut || 'ease-in',
      easeTime: options.disableTimeOut || 300,
      enableHtml: options.enableHtml || false,
      progressBar: options.progressBar || true,
      progressAnimation: options.progressAnimation || 'decreasing',
      toastClass: options.toastClass || 'ngx-toastr',
      positionClass: options.positionClass || 'toast-top-right',
      titleClass: options.titleClass || 'toast-title',
      messageClass: options.messageClass || 'toast-message',
      tapToDismiss: options.tapToDismiss || true,
      onActivateTick: options.onActivateTick || true
    };

    for (let property in opt) {
      if (opt.hasOwnProperty(property) && opt[property] === undefined) {
        delete opt[property];
      }
    }

    return opt;
  }

  showToastrSuccess(title, message = null, options = null) {
    let opt = AlertService.createOptionsForToaster(options);
    this.toastr.success(message, title, opt);
  }

  showToastrError(title: string, message?: string, options = null) {
    let opt = AlertService.createOptionsForToaster(options);
    this.toastr.error(message ?? '', title, opt);
  }

  showToastrInfo(title: string, message?: string, options = null) {
    let opt = AlertService.createOptionsForToaster(options);
    this.toastr.info(message ?? '', title, opt);
  }

  showToastrWarning(message, title, options) {
    let opt = AlertService.createOptionsForToaster(options);
    this.toastr.warning(message, title, opt);
  }

}

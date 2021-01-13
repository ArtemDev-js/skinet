import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequsetCount = 0;

  constructor(private spinnerService: NgxSpinnerService) { }

  busy() {
    this.busyRequsetCount++;
    this.spinnerService.show(undefined, {
      type: 'ball-spin-clockwise-fade-rotating',
      bdColor: 'rgba(255,255,255,0.7)',
      color: '#333333'
    });
  }

  idle() {
    this.busyRequsetCount--;
    if (this.busyRequsetCount <= 0) {
        this.busyRequsetCount = 0;
        this.spinnerService.hide();
    }
  }
}

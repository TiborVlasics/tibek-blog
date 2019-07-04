import { Injectable, isDevMode } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppInitService {
  private apiUrl: string;

  constructor() {}

  public getApiUrl() {
    return this.apiUrl;
  }

  public init() {
    return new Promise((resolve, reject) => {
      this.apiUrl = isDevMode()
        ? 'https://localhost:5001/api'
        : `${window.location.href}api`;

      resolve();
    });
  }
}

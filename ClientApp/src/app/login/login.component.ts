import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  Login: Login = new Login();
  userName: string;
  password: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ValidateLogin() {
    if (this.userName == '' || this.password == '') {
      alert('Please enter Username/Password');
    }
    else {
      this.Login.userName = this.userName;
      this.Login.password = this.password;
      debugger;
      this.http.post<any[]>(this.baseUrl + 'api/Login', this.Login).subscribe(result => {
        if (result) {
          alert('success')
        }
        else {
          alert('error')
        }
      }
      );
    }
  }
}
export class Login {
  userName: string;
  password: string;
}

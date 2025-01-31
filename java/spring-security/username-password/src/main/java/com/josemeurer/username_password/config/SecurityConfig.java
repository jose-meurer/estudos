package com.josemeurer.username_password.config;

import com.josemeurer.username_password.entity.User;
import com.josemeurer.username_password.service.UserService;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.Customizer;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.authentication.configuration.AuthenticationConfiguration;
import org.springframework.security.config.annotation.method.configuration.EnableMethodSecurity;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.SecurityFilterChain;

import javax.swing.*;

@Configuration
@EnableMethodSecurity
public class SecurityConfig {

    private final UserService userService;

    public SecurityConfig(UserService userService) {
        this.userService = userService;
    }

    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {
        http
                .csrf(csrf -> csrf.disable())
                .authorizeHttpRequests(auth -> auth
                        .requestMatchers("/public/**").permitAll()
                        .anyRequest().authenticated())
                /*
                    O cliente envia as credenciais (usuário e senha) em cada requisição, codificadas em Base64 no cabeçalho Authorization.
                    Exemplo de cabeçalho: Authorization: Basic dXNlcm5hbWU6c2VuaGE=
                 */
                .httpBasic(Customizer.withDefaults())

                /*
                    Spring Security cria uma sessão HTTP no servidor e envia um cookie de sessão (como JSESSIONID) para o cliente.
                    Nas próximas requisições, o cliente envia esse cookie, e o servidor valida a sessão.
                    Você não precisa enviar usuário/senha novamente enquanto a sessão estiver ativa.
                 */
//                .formLogin(Customizer.withDefaults())
                .userDetailsService(userService);
        return http.build();
    }

        /*
            Usando .formLogin() ou .httpBasic() e não está injetando o AuthenticationManager em lugar nenhum,
            não é necessário expor o AuthenticationManager como um Bean. O Spring Security já o configura internamente!
         */
//    @Bean
//    public AuthenticationManager authenticationManager(AuthenticationConfiguration authConfig) throws Exception {
//        return authConfig.getAuthenticationManager();
//    }

    @Bean
    PasswordEncoder passwordEncoder() {
        return new BCryptPasswordEncoder();
    }
}

package com.josemeurer.username_password.service;

import com.josemeurer.username_password.entity.User;
import com.josemeurer.username_password.repository.UserRepository;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import java.util.Optional;

@Service
public class UserService implements UserDetailsService {

    private final UserRepository userRepository;

    public UserService(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        Optional<User> optional = userRepository.findByUsername(username);
        User user = optional.orElseThrow(() ->
                new UsernameNotFoundException("User Not Found with username: " + username));
        return user;
    }
}

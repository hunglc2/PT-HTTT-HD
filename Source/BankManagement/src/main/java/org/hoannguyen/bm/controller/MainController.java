package org.hoannguyen.bm.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class MainController {
	
	@RequestMapping("/welcome")
    public String index(Model model) {
        model.addAttribute("title", "Login page");
        return "login";
    }
	
	@SuppressWarnings("null")
	@RequestMapping(value="/login", method=RequestMethod.POST)
    public String login(@RequestParam(value = "error", required = false) String error, 
    							@RequestParam(value = "logout", required = false) String logout) {
		//ModelAndView model = new ModelAndView();
		Model model = null;
		try {
			if (error != null) {
				model.addAttribute("error", "Invalid username and password!");
				return null;
			}

			if (logout != null) {
				model.addAttribute("msg", "You've been logged out successfully.");
				return null;
			}
			
			return "main";
		} catch (Exception e) {
			return logout;	
		}
    }
	
//	@RequestMapping("/main")
//    public String main(Model model) {
//        model.addAttribute("title", "CRM Model HoanNguyen | Starter");
//        return "";
//    }
}

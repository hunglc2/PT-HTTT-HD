package controller;

import java.util.ArrayList;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import model.AccountType;
import service.AccountTypeService;

@Controller
@RestController
@RequestMapping("/accounttype")
public class AccountTypeController {
	@Autowired
	AccountTypeService ps;

	@RequestMapping(method = RequestMethod.GET, value = "/all")
	public ArrayList<AccountType> getAll() {
		return ps.getAll();
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked" })
	@RequestMapping(value = "/{id}", method = RequestMethod.GET)
	public ResponseEntity getByID(@PathVariable("id") String id) {
		AccountType vObject = ps.getByID(Integer.parseInt(id));
		if (vObject == null) {
			return new ResponseEntity("No AccountType found for ID " + id, HttpStatus.NOT_FOUND);
		}
		
		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
	@SuppressWarnings({ "unchecked", "rawtypes", "null" })
	@RequestMapping(value = "/update", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<AccountType> updateOwner(@RequestBody AccountType vObject) {
		vObject = ps.update(vObject);
		if (vObject == null) {
			return new ResponseEntity("No AccountType found for ID " + vObject.getIdAccountType(), HttpStatus.NOT_FOUND);
		}

		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked" })
	@RequestMapping(value = "/insert", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<AccountType> insertOwner(@RequestBody AccountType vObject) {
		return new ResponseEntity(ps.insert(vObject), HttpStatus.OK);
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked", "null" })
	@RequestMapping(value = "/delete", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<AccountType> deletetOwner(@RequestBody AccountType vObject) {
		vObject = ps.delete(vObject);
		if (vObject == null) {
			return new ResponseEntity("No Owner found for ID " + vObject.getIdAccountType(), HttpStatus.NOT_FOUND);
		}
		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
}

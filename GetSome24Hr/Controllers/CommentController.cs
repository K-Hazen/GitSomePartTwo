﻿using GetSome.Models;
using GetSome.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetSome24Hr.Controllers
{
    public class CommentController : ApiController
    {

        //Creating a method to new up instance of CommentService 
        private CommentServices CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var commentService = new CommentServices(userId);
            return commentService;
        }

        //GET (RETRIEVE COMMENTS)

        public IHttpActionResult Get()
        {
            CommentServices commentService = CreateCommentService();
            var comments = commentService.GetComments();
            return Ok(comments);
        }

        public IHttpActionResult Get(int id)
        {
            CommentServices commentService = CreateCommentService();
            var comment = commentService.GetCommentbyId(id);
            return Ok(comment);

        }

        //POST (CREATE) COMMENT
        public IHttpActionResult Post(CommentCreate comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(comment))
                return InternalServerError();

            return Ok();
        }

        //PUT (UPDATE) COMMENT

        public IHttpActionResult Put(CommentEdit comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.UpdateComment(comment))
                return InternalServerError();

            return Ok();
        }

        //DELETE COMMENT
        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.DeleteComment(id))
                return InternalServerError();

            return Ok();
        }

    }

}


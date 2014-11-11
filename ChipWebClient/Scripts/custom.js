var body = $('.body');
var content = $('#content');
var controller = 'Home';
var caption = $('.page-title');

var curPage = {
    content: '',
    action: '',
    title: ''
};
var pages = {
    schedules: { content: '', action: 'Schedules', section: 'Schedules', title: 'Schedules' },
    teachers: { content: '', action: 'Management', section: 'Teachers', title: 'Teachers' },
    lessons: { content: '', action: 'Management', section: 'Lessons', title: 'Lessons' },
    subjects: { content: '', action: 'Management', section: 'Subjects', title: 'Subjects' },
    groups: { content: '', action: 'Management', section: 'Groups', title: 'Groups' }
};

$(document).ready(function () {
    body = $('.body');
    $('#left-bar').bigtext();
    $.fn.extend({
        animateSequentially: function () {
            this.each(function (i) {
                $(this).delay((i++) * 20).fadeTo(500, 1);
            });
        },
    });
});
Resize();

function Load(page) {
    switch (page) {
        case 'Schedules':
            curPage = pages.schedules; break;
        case 'Groups':
            curPage = pages.groups; break;
        case 'Teachers':
            curPage = pages.teachers; break;
        case 'Subjects':
            curPage = pages.subjects; break;
        case 'Lessons':
            curPage = pages.lessons; break;
    }
    caption.text(curPage.title);
    caption.show();
    LoadContent();
}

function LoadContent() {
    $.post(controller + '/' + curPage.action,
        { section: curPage.section },
        function (result) {
        content.html(result);
    })
        .fail(function (xhr) {
            DisplayErrorMessage(xhr.responseText);
        });
}

function DisplayErrorMessage(html) {
}

function LoadDetails(index) {
    $.post(controller + '/' + curPage.action, function (result) {
        content.html(result);
    })
        .fail(function (xhr) {
            DisplayErrorMessage(xhr.responseText);
        });
}

window.onresize = function () {
    window.setTimeout(Resize, 100);
}

function Add(data) {
    Send('Add', { data: data });
}
function Edit(id, data) {
    Send('Edit', { id: id, data:data});
}
function Remove(id) {
    Send('Remove', { id: id });
}
function Send(action, table, data) {
    $.post(controller + '/' + curPage.action, data, function (result) {
            alert('success');
        })
   .fail(function (xhr) {
       DisplayErrorMessage(xhr.responseText);
   });
}
function Resize() {
    var width;
    if (body.width() > body.height()) {
        width = body.height();
    } else {
        width = body.width();
    }
    var container = $('#container');
    $('#container').width(width);
    container.height(width * 0.6);
    container.margin({
        left: body.width() * 0.5
            - container.width() * 0.5 - container.padding().left
    });
}
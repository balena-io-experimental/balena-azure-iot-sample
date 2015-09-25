
add_executable(httpapiex_unittests httpapiex_unittests.cpp main.c)


target_include_directories(httpapiex_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (httpapiex_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
